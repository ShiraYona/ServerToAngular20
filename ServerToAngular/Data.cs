using ServerToAngular.Models;

namespace ServerToAngular
{
    public class Data
    {
        public static List<Donor> donors = new List<Donor>
        {
            new Donor(1,"aaa","aaaaaaaaaa") ,
            new Donor(2,"bbb","bbbbbbbbbb"),
            new Donor(3,"ccc","cccccccccc")

        };

        public static List<Gift> gifts = new List<Gift>
        {
            new Gift(1,"camera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(2,"car",donors[1].Name,40,"2.png","good car",1),
            new Gift(3,"house",donors[2].Name,50,"3.png","good house",1),
            new Gift(4,"gift",donors[1].Name,60,"4.png","good gift",1),
                        new Gift(10,"camera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(5,"cakmera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(6,"camkera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(7,"caoimera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(8,"cakimera",donors[0].Name,30,"1.png","good camera",1) ,
             new Gift(9,"camera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(11,"car",donors[1].Name,40,"2.png","good car",1),
            new Gift(12,"house",donors[2].Name,50,"3.png","good house",1),
            new Gift(13,"gift",donors[1].Name,60,"4.png","good gift",1),
                        new Gift(1,"camera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(14,"cakmera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(15,"camkera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(16,"caoimera",donors[0].Name,30,"1.png","good camera",1) ,
            new Gift(17,"cakimera",donors[0].Name,30,"1.png","good camera",1) ,


        };
        
        public static List<User> users = new List<User>
        {
            new User(1,"user1","user1","12345678",gifts),
            new User(2,"user2","user2","44444444",gifts),
            new User(3,"user3","user3","87878787",gifts)
        };
    }
}
