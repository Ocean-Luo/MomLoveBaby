using Microsoft.AspNetCore.Mvc;

namespace MomLoveBaby.Controllers
{
    public class PregnancyController : Controller
    {
        /// <summary>
        /// 显示孕期主页
        /// </summary>
        /// <returns>返回孕期主页视图</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 显示孕期准备页面
        /// </summary>
        /// <returns>返回孕期准备视图</returns>
        public IActionResult Preparation()
        {
            return View();
        }

        /// <summary>
        /// 显示孕前准备页面
        /// </summary>
        /// <returns>返回孕前准备视图</returns>
        public IActionResult PrePregnancy()
        {
            return View();
        }

        /// <summary>
        /// 显示孕期页面
        /// </summary>
        /// <returns>返回孕期视图</returns>
        public IActionResult Pregnancy()
        {
            return View();
        }

        /// <summary>
        /// 显示产检页面
        /// </summary>
        /// <returns>返回产检视图</returns>
        public IActionResult PrenatalCheck()
        {
            return View();
        }

        /// <summary>
        /// 显示产假页面
        /// </summary>
        /// <returns>返回产假视图</returns>
        public IActionResult MaternityLeave()
        {
            return View();
        }

        /// <summary>
        /// 显示分娩页面
        /// </summary>
        /// <returns>返回分娩视图</returns>
        public IActionResult Childbirth()
        {
            return View();
        }

        /// <summary>
        /// 显示产后页面
        /// </summary>
        /// <returns>返回产后视图</returns>
        public IActionResult Postpartum()
        {
            return View();
        }
    }
}