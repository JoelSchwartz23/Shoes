using System.Collections.Generic;
using shoes.Models;

namespace shoes.Db
{
  static class FakeDB
  {
    public static List<Shoe> Shoes = new List<Shoe>(){
      new Shoe("Yellow Shoe", "It's Yellow"),
      new Shoe("Blue Shoe", "It's Blue"),
      new Shoe("Red Shoe", "It's Red")
  };
  }
}