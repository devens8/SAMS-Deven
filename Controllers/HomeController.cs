using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAMS.Data;
using SAMS.Models;
using System.Diagnostics;
using System.Linq;

namespace SAMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "Student, Developer")]
        public async Task<IActionResult> Scan()
        {
            var user = await _userManager.GetUserAsync(User);
            ViewBag.schooliD = user.SchoolId;
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Scan(string camResult, DateTime camResultTimeStamp, string theid)
        {
            string camResultController = camResult;
            DateTime camResultTimeStampController = camResultTimeStamp;
            string theschoolidController = theid;

            //getting the student with the correct student ID

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var schoolIDdb = user.SchoolId;
            if (schoolIDdb == null)
            {
                return NotFound($"Unable to find the school id with the user with ID '{_userManager.GetUserId(User)}'.");
            }
            else
            {
                if (schoolIDdb == theschoolidController)
                {
                    int bellScheduleEnabled = 0;
                }
            }



            DateTime currentTime = DateTime.Now;

            List<string> roomCodes = _context.roomCodeModels.Select(a => a.RoomCode).ToList();
            string chosenBellSchedule = _context.chosenBellSchedModels.Select(a => a.Name).ToQueryString();
            List<TimeSpan> dailybellSchedule = _context.dailyBellScheduleModels.Select(a => a.StartTime).ToList();
            List<TimeSpan> dailybellDuration = _context.dailyBellScheduleModels.Select(a => a.Duration).ToList();

            List<TimeSpan> twoHourDelaySchedule = _context.twoHrDelayBellScheduleModels.Select(a => a.StartTime).ToList();
            List<TimeSpan> twoHourDelayDuration = _context.twoHrDelayBellScheduleModels.Select(a => a.Duration).ToList();

            List<TimeSpan> pepRallySchedule = _context.pepRallyBellScheduleModels.Select(a => a.StartTime).ToList();
            List<TimeSpan> pepRallyDuration = _context.pepRallyBellScheduleModels.Select(a => a.Duration).ToList();

            List<TimeSpan> extendedAvesSchedule = _context.extendedAvesModels.Select(a => a.StartTime).ToList();
            List<TimeSpan> extendedAvesDuration = _context.extendedAvesModels.Select(a => a.Duration).ToList();

            List<int> studentBell = _context.studentScheduleInfoModels.Select(a => a.Bell1EnrollmentCodeMod).ToList();

            for (int indexer = 0; indexer < roomCodes.Count; indexer++)
            {
                if (roomCodes[indexer].Equals(camResultController))
                {
                    if (chosenBellSchedule.Equals("Daily Bell Schedule"))
                    {
                        for (int i = 0; i < dailybellSchedule.Count; i++)
                        {
                            if (camResultTimeStampController.Subtract(dailybellSchedule[i]).TimeOfDay < dailybellDuration[i])
                            {
                                return NotFound($"Your atendance has been marked for '{studentBell[0]}'"); //change this to view later

                            }
                        }
                        return NotFound($"You are not supposed to be in this bell right now'"); //change this to view later
                    }
                    else if (chosenBellSchedule.Equals("2 Hour Delay Bell Schedule"))
                    {
                        for (int i = 0; i < twoHourDelaySchedule.Count; i++)
                        {
                            if (camResultTimeStampController.Subtract(twoHourDelaySchedule[i]).TimeOfDay < twoHourDelayDuration[i])
                            {
                                return NotFound($"Your atendance has been marked for '{studentBell[0]}'"); //change this to view later

                            }
                        }
                        return NotFound($"You are not supposed to be in this bell right now'"); //change this to view later

                    }
                    else if (chosenBellSchedule.Equals("Pep Rally Bell Schedule"))
                    {
                        for (int i = 0; i < pepRallySchedule.Count; i++)
                        {
                            if (camResultTimeStampController.Subtract(pepRallySchedule[i]).TimeOfDay < pepRallyDuration[i])
                            {
                                return NotFound($"Your atendance has been marked for '{studentBell[0]}'"); //change this to view later

                            }
                        }
                        return NotFound($"You are not supposed to be in this bell right now'"); //change this to view later

                    }
                    else if (chosenBellSchedule.Equals("Extended Aves Bell Schedule"))
                    {
                        for (int i = 0; i < extendedAvesSchedule.Count; i++)
                        {
                            if (camResultTimeStampController.Subtract(extendedAvesSchedule[i]).TimeOfDay < extendedAvesDuration[i])
                            {
                                return NotFound($"Your atendance has been marked for '{studentBell[0]}'"); //change this to view later

                            }
                        }
                        return NotFound($"You are not supposed to be in this bell right now'"); //change this to view later
                    }

                }
            }

            return NotFound($"The QR code you scanned does not match with a Room. Try again");

            //Getting the class code and comparing it
            //return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}