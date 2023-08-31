int count = 0;
double distance = 10000;
double firstFriendSpeed = 2;
double secondFriendSpeed = 5;
double dogSpeed = 50;
double friend = 2;
double time;
while(distance > 10){
    if(friend == 1){
        time = distance/(dogSpeed + secondFriendSpeed);
        friend = 2;
    } else {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance -= time*(firstFriendSpeed + secondFriendSpeed);
    count++;
}
Console.WriteLine("Количество пробегов собаки " + count);
