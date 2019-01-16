using System;
using System.Collections.Generic;
using shoes.Db;
using shoes.Models;

namespace shoes.Repositories
{
  public class ShoeRepository
  {
    // private readonly FakeDB _db;

    // public IEnumerable<Shoes> GetAll()
    // {
    //   return _db.Query<IEnumerable<Shoes>>(@"
    //   SELECT * FROM Shoes;
    //   ")



    // }

    public Shoe GetShoeById(int id)
    {
      try
      {
        return FakeDB.Shoes[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public Shoe AddShoe(Shoe newshoe)
    {
      FakeDB.Shoes.Add(newshoe);
      return newshoe;
    }

    public Shoe EditShoe(int id, Shoe newshoe)
    {
      try
      {
        FakeDB.Shoes[id] = newshoe;
        return newshoe;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }


    public bool DeleteShoe(int id)
    {
      try
      {
        FakeDB.Shoes.Remove(FakeDB.Shoes[id]);
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return false;
      }
    }







    public ShoeRepository()
    {

    }
  }
}