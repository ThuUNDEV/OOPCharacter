using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterProject
{
    internal class Soldier : Robot
    {
        private float _size;
        private DameType _dameType;

        public Soldier()
        {
        }

        public Soldier(int id, string name, float dame, float ammor, float size, DameType dameType) : base(id, name, dame, ammor)
        {
            _size = size;
            _dameType = dameType;
        }

        public override void Run()
        {
            base.Run();
        }

        public void Learn()
        {

        }
    }

    public enum DameType
    {
        Magic,//dame phep
        Physic //dame vat li
    }
}
