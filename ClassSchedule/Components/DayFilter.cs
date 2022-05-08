using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;

namespace ClassSchedule.Components
{
    public class DayFilter : ViewComponent
    {
        private IRepository<Day> day { get; set; }

        public DayFilter(IRepository<Day> rep) => day = rep;
        public IViewComponentResult Invoke()
        {
            var days = day.List(new QueryOptions<Day>
            {
                OrderBy = d => d.DayId
            });
            return View(days);
        }
    }
}