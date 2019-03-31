using System;

namespace Pattern.ProtoType
{
    public abstract class Shape : ICloneable
    {
        protected String m_id;
        protected String m_shapeType;
        public abstract void Draw();
        public string GetShapeType()
        {
            return m_shapeType;
        }
        public string GetID()
        {
            return m_id;
        }
        public void SetID(string id)
        {
            m_id = id;
        }
        //public abstract object Clone();
        public object Clone() {
            return base.MemberwiseClone();
        }
    }
}