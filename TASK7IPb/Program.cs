int populationOfFinland = 5518000;
int populationOfCormorants = 53400;
double growthOfCormorants = 1.08;
double year1 = 2018;
//Let's calculate the new population of Finland in 60 years, when the growth is 0.1% on a yearly basis:
double result1 = Math.Pow(1.001, 60);
double newPopulationOfFinland = populationOfFinland * result1;
//Then let's calculate the year when the population of cormorants reach the new population of Finland:
double result2 = newPopulationOfFinland / populationOfCormorants;
double result3 = Math.Log(result2) / Math.Log(growthOfCormorants);
double year2 = result3 + year1;
year2 = Convert.ToInt32(year2);
Console.WriteLine("Number of cormorants equal to Finnish population: " + year2);



