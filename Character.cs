using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterProject
{
    internal class Character
    {
        private int _id;
        private string _name;
        private float _dame;
        private float _ammor;

        public Character()
        {

        }

        public Character(int id, string name, float dame, float ammor)
        {
            _id = id;
            _name = name;
            _dame = dame;
            _ammor = ammor;
        }

        /// <summary>
        /// Phương thức xử lí chạy của character
        /// </summary>
        public virtual void Run()
        {

        }


        public void Attack()
        {

        }


        public void Defense()
        {

        }


        public void Sound()
        {

        }


    }
}
