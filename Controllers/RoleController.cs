using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SAMS_Deven.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
            
        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager) {
        
            _roleManager = roleManager;
            _userManager = userManager;
        }
            
        public async Task<IActionResult> CreateRole()
        {
            var developer = await _roleManager.CreateAsync(new IdentityRole("Developer"));
            var hsAdmin = await _roleManager.CreateAsync(new IdentityRole("HS Admin"));
            var synLabAdmin = await _roleManager.CreateAsync(new IdentityRole("Synnovation Lab Admin"));            
            var educationSupport = await _roleManager.CreateAsync(new IdentityRole("Education Support (EA)"));
            var attendanceOfficeMember = await _roleManager.CreateAsync(new IdentityRole("Attendance Office Member"));
            var nurse = await _roleManager.CreateAsync(new IdentityRole("Nurse"));
            var lawEn = await _roleManager.CreateAsync(new IdentityRole("Law Enforcement"));
            var SynlabQR = await _roleManager.CreateAsync(new IdentityRole("Synnovation Lab QR Code Scanner Management"));
            var teacher = await _roleManager.CreateAsync(new IdentityRole("Teacher"));
            var sub = await _roleManager.CreateAsync(new IdentityRole("Substitute Teacher"));
            var students = await _roleManager.CreateAsync(new IdentityRole("Student"));
            var disAd = await _roleManager.CreateAsync(new IdentityRole("District Admin"));

            if (developer.Succeeded && 
                hsAdmin.Succeeded && 
                synLabAdmin.Succeeded && 
                educationSupport.Succeeded && 
                attendanceOfficeMember.Succeeded && 
                nurse.Succeeded && 
                lawEn.Succeeded &&
                SynlabQR.Succeeded &&
                teacher.Succeeded &&
                sub.Succeeded && 
                students.Succeeded &&
                disAd.Succeeded)
            {

                Console.WriteLine("Sucesses");
                return RedirectToAction("Index");

            } else
            {
                Console.WriteLine("Sucess? NO");
            }

            return View();
        }

        public async Task<IActionResult> UserToRole()
        {
            var user = await _userManager.FindByNameAsync("somethingWRONG@gmail.com");
            if (user != null)
            {
                var result = await _userManager.AddToRoleAsync(user, "Developer");
                if (result.Succeeded)
                {
                    Console.WriteLine("successfully added role");
                    return RedirectToAction("Index");
                }
                else
                {
                    Console.WriteLine("Ur a failure");
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
