// Solving cuadratic ecuations with C++

#include <iostream>
#include <math.h>

using namespace std;

int main(){
    // The a, b and c values are given by the user
    // x1 and x2 will be the result values

    float a, b, c, x1, x2;

    cout<<"Enter the value of a: "<<endl;
    cin>>a;

    cout<<"Enter the value of c: "<<endl;
    cin>>b;

    cout<<"Enter the value of b: "<<endl;
    cin>>c;

    // As the formula tells us, we subtract the value of b raised to 2 (b * b), with the value of 4 * a * c

    float x (b*b) - (4*a*c)

    // If x value is negative, the solution will be in complex numbers

    if(x <= 0{
        x = x*(-1);
        cout<<"Solution only with complex numbers"<<endl;
        cout<<"Solution using complex numbers: "<<endl;
        cout<<(-b(2*a))<<" + " <<(sqrt(x)/(2*a))<<"i and "<<(-b/(2*a))<<" - "<<(sqrt(x)/(2*a))<<"i"<<endl;
    }else{
        // If x value is positve, thee solution will be in real numbers

        x1 = (-b + sqrt(x)) / (2*a);
        x2 = (-b - sqrt(x)) / (2*a);

        cout<<"x1 = "<<x1<<endl;
        cout<<"x2 = "<<x2<<endl;
    }
    return 0;
}