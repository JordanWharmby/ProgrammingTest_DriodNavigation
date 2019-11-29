public class CommandClass{

    private char direction;
    private int steps;

    public CommandClass(string comand) {
        if (comand.Length <= 0) return;
        //Gets the direction order
        direction = comand[0];
        //Calculates the steps
        steps = 0;
        //Loops through the string and calculates the steps
        for(int i = 0; i < comand.Length; i++) {
            if (comand[i] == '-') steps--;
            else if (comand[i] == '+') steps++;
        }
    }

    public string ShowComabd() { return direction + " : " + steps; }

    //Returns the direction to go in
    public char Direction() { return direction; }

    //Returns the number of steps that need to be taken
    public int GetSetps() { return steps; }

}
