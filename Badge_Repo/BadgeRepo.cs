using Badge_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_Repo
{
    public class BadgeRepo
    {
        private Dictionary<int, List<string>> _dictOfBadges = new Dictionary<int, List<string>>();

        //Create Badge
        public void Create(Badge badge)
        {
            _dictOfBadges.Add(badge.ID, badge.DoorNames);
        }
       //Read Badge
        public Dictionary<int, List<string>> GetDictOfBadges()
        {
            return _dictOfBadges;
        }
        //Helper Get Badge By Badge Number?
        public Badge GetBadgeByNumber(int badgeNumber)
        {
            if (_dictOfBadges.ContainsKey(badgeNumber))
            {
                List<string> doorNames = _dictOfBadges[badgeNumber];
                Badge badge = new Badge(badgeNumber, doorNames);
                return badge;
            }
            else
            {
                return null;
            }       
        }

    }

}
