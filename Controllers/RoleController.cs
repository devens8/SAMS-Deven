using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SAMS.Models;

namespace SAMS.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> CreateRole()
        {
            var developer = await _roleManager.CreateAsync(new IdentityRole("Developer"));
            var hsSchoolAdmin = await _roleManager.CreateAsync(new IdentityRole("HS School Admin"));
            var synnLabAdmin = await _roleManager.CreateAsync(new IdentityRole("Synnovation Lab Admin"));
            var EAsupport = await _roleManager.CreateAsync(new IdentityRole("Education Support (EA)"));
            var AttendanceOffMem = await _roleManager.CreateAsync(new IdentityRole("Attendance Office Member"));
            var nurse = await _roleManager.CreateAsync(new IdentityRole("Nurse"));
            var lawEnforce = await _roleManager.CreateAsync(new IdentityRole("Law Enforcement"));
            var synnQRmanagement = await _roleManager.CreateAsync(new IdentityRole("Synnovation Lab QR code Scanner Management"));
            var teacher = await _roleManager.CreateAsync(new IdentityRole("Teacher"));
            var SubTeacher = await _roleManager.CreateAsync(new IdentityRole("Substitute Teacher"));
            var student = await _roleManager.CreateAsync(new IdentityRole("Student"));
            var districtAdmin = await _roleManager.CreateAsync(new IdentityRole("District Admin"));

            if (developer.Succeeded && 
                hsSchoolAdmin.Succeeded && 
                synnLabAdmin.Succeeded && 
                EAsupport.Succeeded && 
                AttendanceOffMem.Succeeded && 
                nurse.Succeeded && 
                lawEnforce.Succeeded && 
                teacher.Succeeded &&
                SubTeacher.Succeeded &&
                student.Succeeded &&
                districtAdmin.Succeeded)
            {
                Console.WriteLine("The Role Creation worked.");
                return RedirectToAction("Index");
            }
            else
            {
                Console.WriteLine("The role creation did not work.");
                Console.WriteLine("School Admin: " + developer.Succeeded);
            }
            return View();
        }

        public async Task<IActionResult> UserToRole()
        {
            var user = await _userManager.FindByNameAsync("vyasshivam2006@gmail.com");
            if (user != null)
            {
                var result = await _userManager.AddToRoleAsync(user, "Developer");
                if (result.Succeeded)
                {
                    Console.WriteLine("It worked.");
                    return RedirectToAction("Index");

                } else
                {
                    Console.WriteLine("It did not work.");
                }
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
