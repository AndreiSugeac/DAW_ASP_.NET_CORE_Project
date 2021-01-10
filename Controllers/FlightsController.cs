using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketLine.Data;
using TicketLine.Models;

namespace TicketLine.Controllers
{
    public class FlightsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        public FlightsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<string> GetCurrentUserId()
        {
            ApplicationUser usr = await GetCurrentUserAsync();
            return usr?.Id;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Flights
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Flight.Include(f => f.Boarding).Include(f => f.Destination);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Flights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flight
                .Include(f => f.Boarding)
                .Include(f => f.Destination)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // GET: Flights/Create
        public IActionResult Create()
        {
            ViewData["BoardingId"] = new SelectList(_context.Airport, "Id", "City");
            ViewData["DestinationId"] = new SelectList(_context.Airport, "Id", "City");
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BoardingId,DestinationId,TakeoffTime,ArrivalTime")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BoardingId"] = new SelectList(_context.Airport, "Id", "City", flight.BoardingId);
            ViewData["DestinationId"] = new SelectList(_context.Airport, "Id", "City", flight.DestinationId);
            return View(flight);
        }

        // GET: Flights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flight.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }
            ViewData["BoardingId"] = new SelectList(_context.Airport, "Id", "City", flight.BoardingId);
            ViewData["DestinationId"] = new SelectList(_context.Airport, "Id", "City", flight.DestinationId);
            return View(flight);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BoardingId,DestinationId,TakeoffTime,ArrivalTime")] Flight flight)
        {
            if (id != flight.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightExists(flight.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BoardingId"] = new SelectList(_context.Airport, "Id", "City", flight.BoardingId);
            ViewData["DestinationId"] = new SelectList(_context.Airport, "Id", "City", flight.DestinationId);
            return View(flight);
        }

        // GET: Flights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flight
                .Include(f => f.Boarding)
                .Include(f => f.Destination)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flight = await _context.Flight.FindAsync(id);
            _context.Flight.Remove(flight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        // POST : Flights/CreateTicket/5
        public async Task<IActionResult> CreateTicket(int id)
        {
            var flight = await _context.Flight.FindAsync(id);
            var airplane = _context.Airplane.Where(p => p.FlightId == id);
            var seat = _context.Seat.Include(f => f.Ticket).Where(p => p.AirplaneId == airplane.FirstOrDefault().Id && p.Ticket == null);

            if(seat == null)
            {
                ModelState.AddModelError(string.Empty, "No more seats are left for this flight.");
                return RedirectToAction(nameof(Index));
            }

            var ticket = new Ticket
            {
                SeatId = seat.FirstOrDefault().Id,
                OwnerId = await GetCurrentUserId()
            };

            if (ticket != null)
            {
                _context.Ticket.Add(ticket);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Your request could not be processed!");
                return RedirectToAction(nameof(Index));
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        private bool FlightExists(int id)
        {
            return _context.Flight.Any(e => e.Id == id);
        }
    }
}
