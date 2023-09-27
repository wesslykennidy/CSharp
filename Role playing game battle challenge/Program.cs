int hero = 10;
int monster = 10;
int current = 0;
Random random = new Random();

do{
    current = random.Next(1,11);
    hero -= current;
    Console.WriteLine($"Hero was damaged and lost {current} health and now has {hero} health.");
    
    if (hero <= 0) continue;

    current = random.Next(1,11);
    monster -=current;
    Console.WriteLine($"Monster was damaged and lost {current} health and now has {monster} health.");

    
}while (hero > 0 && monster > 0);

if (hero <= 0){
    Console.WriteLine("Monster wins!");
}else{
    Console.WriteLine("Hero wins");
}