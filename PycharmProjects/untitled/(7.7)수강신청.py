inform={}
list_user1=[]
list_user2=[]
list_user3=[]
list_user4=[]
count=0
r=open('subject.txt','r')
r_user=open('user.txt','r')
while(True):
    readline=r.readline()
    if(readline==""):
        break;
    else:
        subject_Name, Code= readline.split()
        inform[Code]=subject_Name
while(True):
    user_readline=r_user.readline()
    if(user_readline==""):
        break;
    else:
        if(count==0):
            list_user1=user_readline.split()
            count+=1
        elif(count==1):
            list_user2=user_readline.split()
            count+=1
        elif(count==2):
            list_user3=user_readline.split()
            count+=1
        elif(count==3):
            list_user4=user_readline.split()
            count+=1
while(True):
    print '1. whole_list '
    print '2. apply_addtion '
    print '3. delete '
    print '4. user_list '
    choose_num=input()
    if(choose_num==1):
        print inform
    elif (choose_num==2):
        user_Name=raw_input("user_Name : ")
        subject_Code=raw_input("subject_Code : ")
        if(user_Name==list_user1[0]):
            list_user1.append(subject_Code)
        elif(user_Name==list_user2[0]):
            list_user2.append(subject_Code)
        elif(user_Name==list_user3[0]):
            list_user3.append(subject_Code)
        elif(user_Name==list_user4[0]):
            list_user4.append(subject_Code)
    elif(choose_num==3):
        user_Name=raw_input("user_Name : ")
        subject_Code=raw_input("subject_Code : ")
        if(user_Name==list_user1[0]):
            list_user1.remove(subject_Code)
        elif(user_Name==list_user2[0]):
            list_user2.remove(subject_Code)
        elif(user_Name==list_user3[0]):
            list_user3.remove(subject_Code)
        elif(user_Name==list_user4[0]):
            list_user4.remove(subject_Code)
    elif(choose_num==4):
        user_Name=raw_input("user_Name : ")
        if(user_Name==list_user1[0]):
            for item in list_user1[1:]:
                print inform[item]
        elif(user_Name==list_user2[0]):
             for item in list_user2[1:]:
                print inform[item]
        elif(user_Name==list_user3[0]):
             for item in list_user3[1:]:
                print inform[item]
        elif(user_Name==list_user4[0]):
             for item in list_user4[1:]:
                print inform[item]





