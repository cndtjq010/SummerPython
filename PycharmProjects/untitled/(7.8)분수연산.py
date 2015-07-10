class Fration :
    a=0
    b=0
    c=0
    up=0
    up_save=0
    down_save=0
    down=0
    def __init__(self,a,b):
       self.a=a
       self.b=b
    def __init__(other,a,b):
        other.a=a
        other.b=b
    def __add__(self, other):
        if(self.b==other.b):
            self.up=self.a+other.a
            self.down=self.b
            self.up_save=self.up
            self,down_save=self.down
        elif(self.b!=other.b):
            self.up=(self.a*other.b+self.b*other.a)
            self.down=(self.b*other.b)
            self.up_save=self.up
            self.down_save=self.down
    def __sub__(self, other):
        if(self.b==other.b):
            self.up=self.a-other.a
            self.down=self.b
            self.up_save=self.up
            self,down_save=self.down
        elif(self.b!=other.b):
            self.up=(self.a*other.b-self.b+other.a)
            self.down=(self.b*other.b)
            self.up_save=self.up
            self.down_save=self.down
    def __mul__(self, other):
        self.up=self.a*other.a
        self.down=self.b*other.b
        self.up_save=self.up
        self.down_save=self.down
    def __div__(self, other):
        self.up=self.a*other.b
        self.down=self.b*other.a
        self.up_save=self.up
        self.down_save=self.down
    def max(self):
     while(True):
        if(self.up_save>self.down_save):
            self.up_save-=self.down_save
        elif(self.up_save<self.down_save):
            self.down_save-=self.up_save
        elif(self.up_save==self.down_save):
            self.c=self.up_save
            break;
    def fration(self):
        if(self.up==self.down):
            print 1
        else:
            if(self.c!=0):
                print self.up/self.c,'/',self.down/self.c
            else:
                print self.up,'/',self.down

fration1= Fration(3,4)
fration2=Fration(4,3)
fration1+fration2
Fration.max(fration1)
Fration.fration(fration1)
fration1-fration2
Fration.max(fration1)
Fration.fration(fration1)
fration1*fration2
Fration.max(fration1)
Fration.fration(fration1)
fration1/fration2
Fration.max(fration1)
Fration.fration(fration1)