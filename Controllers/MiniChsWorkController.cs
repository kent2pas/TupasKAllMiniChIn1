//Kent Tupas
//10/25/2022
//All Challenges in 1
//Peer Review: Jacob Dekok - Code looks great and organized. The program runs as intended.
using Microsoft.AspNetCore.Mvc;

namespace TupasKminich1.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChsWorkController : ControllerBase
{
   [HttpGet] 
   [Route("MiniChallenge1")]

   public string MiniChallenge1()
   {
         return "Hello People. This is were you type your Name";
   }

   [HttpGet]
   [Route("MiniChallenge2")]

   public int MiniChallenge2()
   {
    return 4 + 4;
   }

   [HttpGet]
   [Route("MiniChallenge3")]

   public string MiniChallenge3()
   {
    return "What is your Name and what Time did you wake up?";
   }

   [HttpGet]
   [Route("MiniChallenge4")]

   public bool MiniChallenge4()
   {
    return 7 < 8;
   }

   [HttpGet]
   [Route("MiniChallenge5")]

   public string MiniChallenge5()
   {
    return "Once upon a time it was a nice day. Then came a dark cloud started raining. It's not just regular water it was acid rain. ";
   }

   [HttpGet]
   [Route("MiniChallenge6")]

   public string MiniChallenge6()
   {
      return " What this code supposed to do you input a number then it outputs if the number is odd or even";
   }

   [HttpGet]
   [Route("MiniChallenge7")]

   public string MiniChallenge7()
   {
     return "You input a number then it would take the number you input outputs in reverse"; 
   }

   [HttpGet]
   [Route("MiniChallenge8")]

   public string MiniChallenge8()

   {
      return " You click on start then it outputs a random question";
   }

   [HttpGet]
   [Route("MiniChallenge9")]

   public string MiniChallenge9()

   {
      return "The user types in what food you want. Mine is pizza , burger, mexican. Then it outputs a random resturant.";
   }











}
