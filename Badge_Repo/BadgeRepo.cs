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
        private Badge _badge = new Badge();

        //Create Badge
        public void Create(Badge badge)
        {
            _badges.Add(badge.ID, badge.DoorNames);
            _ListOfBadges.Add(badge);
        }
        //Add doors to list of doors
        public void AddDoor(string doorNumber)
        {
            _badge.DoorNames.Add(doorNumber);
        }

        public List<Badge> GetListOfBadges()
        {
            return _ListOfBadges;
        }

    }

}
