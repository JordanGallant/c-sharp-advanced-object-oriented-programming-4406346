// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword
class Rectangle {
    // TODO: member variables hold data
public int w;
public in h;


    // TODO: The constructor accepts parameters used to create the object
    public Rectangle(int w, int h){
        this.w =w;
        this.h=h;
    }

    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle(int side){
        this.w =this.h = side;
    }


    // TODO: Classes can define methods that return values


    
}