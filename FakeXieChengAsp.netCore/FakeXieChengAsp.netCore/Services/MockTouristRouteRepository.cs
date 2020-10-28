using FakeXieChengAsp.netCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FakeXieChengAsp.netCore.Services
{
    public class MockTouristRouteRepository : ITouristRouteRepository
    {
        private List<TouristRoute> _routes;
        public MockTouristRouteRepository()
        {
            if (_routes == null)
            {
                InitializeTouristRoutes();
            }
        }

        private void InitializeTouristRoutes()
        {
            _routes = new List<TouristRoute>
            {
                new TouristRoute{
                 Id=Guid.NewGuid(),
                 Title = "黄山",
                 Description = "黄山真好玩",
                 OriginalPrice=1299,
                 Features="<p>吃住行</p>",
                 Fees="<p>交通费用自理</p>",
                 Notes="<p>小心危险</p>"
                },
                new TouristRoute{
                 Id=Guid.NewGuid(),
                 Title = "华山",
                 Description = "华山真好玩",
                 OriginalPrice=1299,
                 Features="<p>吃住行</p>",
                 Fees="<p>交通费用自理</p>",
                 Notes="<p>小心危险</p>"
                },
                new TouristRoute{
                 Id=Guid.NewGuid(),
                 Title = "泰山",
                 Description = "泰山真好玩",
                 OriginalPrice=1299,
                 Features="<p>吃住行</p>",
                 Fees="<p>交通费用自理</p>",
                 Notes="<p>小心危险</p>"
                },
                new TouristRoute{
                 Id=Guid.NewGuid(),
                 Title = "恒山",
                 Description = "恒山真好玩",
                 OriginalPrice=1299,
                 Features="<p>吃住行</p>",
                 Fees="<p>交通费用自理</p>",
                 Notes="<p>小心危险</p>"
                },
            };
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _routes.FirstOrDefault(n=>n.Id==touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _routes;
        }
    }
}
