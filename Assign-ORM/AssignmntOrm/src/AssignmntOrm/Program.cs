using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmntOrm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new Database())
            {
                db.Database.Migrate();
                Console.WriteLine("Enter data for adding product");
                Console.WriteLine("Enter Product description:- ");
                var desc = Console.ReadLine();
                Console.WriteLine("Enter Product Homepage url:- ");
                var url = Console.ReadLine();
                Console.WriteLine("Enter Product name:- ");
                var n = Console.ReadLine();

                db.ProductModels.Add(new ProductModels
                                    {   Description=desc,
                                        HomepageUrl =url,
                                        Name =n
                                    }
                );
              var count = db.SaveChanges();
               Console.WriteLine("Records added to prouducttable", count);
               add update model
                Console.WriteLine("Enter Update table details");
                Console.WriteLine("Enter Update description:- ");
                var updesc = Console.ReadLine();
                Console.WriteLine("Enter update name:- ");
                var upname = Console.ReadLine();
                Console.WriteLine("Enter Productid:- ");
                var pid = int.Parse(Console.ReadLine());

                db.UpdateModels.Add(new UpdateModels
                {
                    Description = updesc,
                    Name = upname,
                    ProductId=pid
                });
               var count2 = db.SaveChanges();
               Console.WriteLine("Records added to Updatetable", count2);
                Console.WriteLine();

             
                Console.WriteLine("update product data");
                Console.WriteLine("Enter Productid:- ");
                var proid = int.Parse(Console.ReadLine());
                Console.WriteLine("EnterDescription:- ");
                var updescc = Console.ReadLine();
                Console.WriteLine("Enter Homepageurl:- ");
                var upurl =Console.ReadLine();
                Console.WriteLine("Enter Name:- ");
                var upnamee = Console.ReadLine();

                db.ProductModels.Update(new ProductModels
                {
                    ProductId=proid,
                    Description = updescc,
                    HomepageUrl=upurl,
                    Name =upnamee
                }
               );
                var count3 = db.SaveChanges();
               Console.WriteLine("Records updated to database", count3);
            

                Console.WriteLine("delete product ");
                Console.WriteLine("Enter Productid:- ");
                var prodid = int.Parse(Console.ReadLine());
 
                db.ProductModels.Remove(new ProductModels
                {
                    ProductId = prodid,
                }
               );
                var count4 = db.SaveChanges();
                Console.WriteLine("PRoduct deleted from database", count4);



                //to view all the products..............
                // Console.WriteLine("All Products in database");
                // foreach(var Product in db.ProductModels)
                //{
                // Console.WriteLine(" -{0}", Product.HomepageUrl);
                // }

            }
            

        }
    }
}
