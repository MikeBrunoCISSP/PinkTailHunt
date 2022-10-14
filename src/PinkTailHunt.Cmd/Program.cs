using PinkTailHunt;

int sirens = new Random().Next(0, 99);
Hunt hunt = new(0,0);
Console.WriteLine($@"Hunt results:
   Sirens at Start        : {sirens}
   Time Spent             : {hunt.TotalTimeSpent}
   Random Encounters      : {hunt.Encounters}
   Ran Away Times         : {hunt.RunTimes}
   Flan Princesses Killed : {hunt.FlanPrincessesKilled}
   Gil Earned             : {hunt.GilEarned}
   Exp Earned             : {hunt.ExpEarned}
   Sirens Left            : {hunt.SirensLeft}");
