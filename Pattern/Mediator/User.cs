using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Mediator
{
    class User
    {
        private string m_name;

        public User(string name)
        {
            this.m_name = name;
        }
        public string GetName()
        {
            return m_name;
        }
        public void SetName(string name)
        {
            m_name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this,message);
        }

    }
}
