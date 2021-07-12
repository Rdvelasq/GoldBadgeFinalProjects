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
        private Dictionary<int, List<string>> _badges = new Dictionary<int, List<string>>();
        private List<Badge> _ListOfBadges = new List<Badge>();

        //Create Badge
        public void Create(Badge badge)
        {
            _badges.Add(badge.ID, badge.DoorNames);
            _ListOfBadges.Add(badge);
        }
       //Read Badge
        public List<Badge> GetListOfBadges()
        {
            return _ListOfBadges;
        }
        //Helper Get Badge By Badge Number?
        public Badge GetBadgeByNumber(int badgeNumber)
        {
            foreach (var Badge in _ListOfBadges)
            {
                if(Badge.Name == badgeNumber)
                {
                    return Badge;
                }
            }
            return null;
        }

    }

}
