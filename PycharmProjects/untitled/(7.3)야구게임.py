import random
while(True):
    number1=random.randrange(1,9)
    number2=random.randrange(1,9)
    number3=random.randrange(1,9)
    if((number1!=number2) and (number2!=number3) and(number1!=number3)):
        break
print number1,number2,number3
while(True):
    strike_count=0
    ball_count=0
    firstnum=input('number1(1~9) :')
    secondnum=input('number2(1~9) :')
    Thirdnum=input('number3(1~9) :')
    if((0>firstnum or firstnum>10) or (0>secondnum or secondnum>10) or (0>Thirdnum or Thirdnum>10)):
        print "wrong range"
        continue
    if(firstnum==number1):
        strike_count+=1
    if(secondnum==number2):
        strike_count+=1
    if(Thirdnum==number3):
        strike_count+=1
    if(firstnum!=number1 and (firstnum==number2 or firstnum==number3)):
        ball_count+=1
    if(secondnum!=number2 and (secondnum==number1 or secondnum==number3)):
        ball_count+=1
    if(Thirdnum!=number3 and (Thirdnum==number1 or Thirdnum==number2)):
         ball_count+=1
    print '#Strike:',strike_count
    print '#Ball:',ball_count
    if(strike_count==3):
        break

