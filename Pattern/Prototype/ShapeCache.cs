using System.Collections;

namespace Pattern.ProtoType
{
    public class ShapeCache
    {
        private static Hashtable ShapeTable = new Hashtable();

        public static void Init() {

            var rectangle = new Rectangle();
            rectangle.SetID("1");
            ShapeTable.Add(rectangle.GetID(),rectangle);
            var circle = new Circle();
            circle.SetID("2");
            ShapeTable.Add(circle.GetID(),circle);
        }
        public static Shape GetShape(string ID) {
            if (ShapeTable.ContainsKey(ID))
            {
                return (Shape)ShapeTable[ID];
            }
            else
            {
                return null;
            }
        }
    }
}
