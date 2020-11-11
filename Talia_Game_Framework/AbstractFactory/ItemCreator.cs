using System;
using System.Collections.Generic;
using System.Text;
using Talia_Game_Framework;

namespace Talia_Game_Framework
{
    public class ItemCreator
    {
        private IEquiptment _item1;
        private  IEquiptment _item2;

       public ItemCreator(AbstractFactory factory) 
       {
            _item1 = factory.CreateBasic();
            _item2 = factory.CreateMagic();
            PlaceInWorld();
       }

       public void PlaceInWorld()
       {
           World.GetInstance().RegisterWorldItems(_item1);
           World.GetInstance().RegisterWorldItems(_item2);
       }
    }
}
