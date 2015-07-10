import math
class shape :
    perimeter=0
    area=0
    def calcArea(self):
        pass
    def calPerimeter(self):
        pass
    def printinfo(self):
        print "Area : {0} , Lenght : {1}".format(self.area,self.perimeter)

class Rectangle(shape) :
    x=0
    y=0
    def __init__(self,x,y):
        self.x=x
        self.y=y
    def calcArea(self):
        Rectangle.area=(self.x*self.y)
    def calPerimeter(self):
        Rectangle.perimeter=2*(self.x+self.y)
class triangle(shape):
    line=0
    def __init__(self,line):
        self.line=line
    def calcArea(self):
        triangle.area=math.sqrt(3)/4*self.line**2
    def calPerimeter(self):
        triangle.perimeter=3*(self.line)
class circle(shape) :
    r=0
    def __init__(self,r):
        self.r=r
    def calcArea(self):
        circle.area=self.r**2*3.141592
    def calPerimeter(self):
        circle.perimeter=2*(self.r*3.141592)

print "Rectangle inform"
inform=Rectangle(4,3)
Rectangle.calcArea(inform)
Rectangle.calPerimeter(inform)
Rectangle.printinfo(inform)

print "Triangle inform"
inform=triangle(4)
triangle.calcArea(inform)
triangle.calPerimeter(inform)
triangle.printinfo(inform)

print "Circle inform"
inform=circle(4)
circle.calcArea(inform)
circle.calPerimeter(inform)
circle.printinfo(inform)