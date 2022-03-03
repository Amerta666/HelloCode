// Собака и друзья

using static System.Console;

Clear();

int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int flag = 2;
int time = 0;

while (distance > 10)
{
    if (flag == 1)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        flag = 2;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        flag = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
    //WriteLine(distance);
}
WriteLine(count);