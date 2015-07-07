refriger={}
r=open("refriger.txt",'r')
while(True):
    read=r.readline()
    if(read==""):
        break;
    elif(read!=""):
        Name, amount=read.split()
        Amount =int (amount)
        refriger[Name]=Amount
w=open("refriger.txt",'w')
def Add():
    Name=raw_input('Input_Name : ')
    Amount=input('Input_Amount : ')
    if(Name in refriger):
         refriger[Name]+=Amount
    elif(Name not in refriger):
         refriger[Name]=Amount

def Delete():
    Name=raw_input('Delete_Name : ')
    Amount=input("Delete Amount : ")
    if(refriger[Name]<Amount):
            print "I don't have much that!"
    if(Name in refriger):
        refriger[Name]-=Amount
    if(refriger[Name]==0):
        del refriger[Name]

def Check():
     print refriger

while(True):
    action=raw_input("add/delete/check/save : ")
    if(action=='add' or action == 'Add'):
        Add()
    elif(action=='delete' or action =='Delete'):
        Delete()
    elif(action=='check' or action=='Check'):
        Check()
    elif(action=="save"):
        for i in refriger.keys():
            w.write(i+' '+str(refriger[i])+'\n')
        break
