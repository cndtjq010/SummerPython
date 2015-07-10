import math
class shape :
    area=0
    def calcArea(self):
        pass
class TwoDim(shape):
    perimeter=0
    def calcPerimeter(self):
        pass
class ThreeDim(shape):
    volume=0
    def calcVolum(self):
        pass
class Rectangle(TwoDim):
    x=0
    y=0
    def __init__(self,x,y):
        self.x=x;
        self.y=y;
    def calcArea(self):
        return self.x*self.y
    def calcPerimeter(self):
        return 2*(self.x+self.y)
class Triangle(TwoDim):
    a=0
    def __init__(self,a):
        self.a=a;
    def calcArea(self):
        return math.sqrt(3)/4*self.a**2
    def calcPerimeter(self):
        return 3*self.a
class Circle(TwoDim):
    r=0
    def __init__(self,r):
        self.r=r
    def calcArea(self):
        return 3.141592*self.r**2
    def calcPerimeter(self):
        return 3.141592*self.r*2
class Cube(ThreeDim):
    a=0
    def __init__(self,a):
        self.a=a
    def calcArea(self):
        return self.a**2*6
    def calcVolum(self):
        return self.a**3
class Sphere(ThreeDim):
    r=0
    def __init__(self,r):
        self.r=r
    def calcArea(self):
        return 4*3.141592*self.r**2
    def calcVolum(self):
        return (4.0/3)*3.141592*self.r**3

Inform=Rectangle(3,3)
print "Rectangle Area : ",Inform.calcArea()
print "Rectangle Perimeter : ",Inform.calcPerimeter()
Inform=Triangle(3)
print "Triangle Area : ",Inform.calcArea()
print "Triangle Perimeter : ",Inform.calcPerimeter()
Inform=Circle(3)
print "Circle Area : ",Inform.calcArea()
print "Circle Perimeter : ",Inform.calcPerimeter()
Inform =Cube(3)
print "Cube Area : ",Inform.calcArea()
print "Cube Perimeter : ",Inform.calcVolum()
Inform =Sphere(3)
print "Sphere Area : ",Inform.calcArea()
print "Sphere Perimeter : ",Inform.calcVolum()
