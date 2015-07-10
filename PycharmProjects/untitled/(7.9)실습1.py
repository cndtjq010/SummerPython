#-*- coding:utf-8 -*-
#파일 입출력 및 예외처리 예제
FileName=raw_input("File Name : ")
try:
    r1=open(FileName+".txt",'a+')
except IOError():
    w=open(FileName+".txt",'w')
    InputContent=raw_input("Content : ")
    w.write(InputContent)
else :
    R=r1.readline()
    print "Origin Content : ",R
    Inputcontent=raw_input("Content : ")
    r1.write(Inputcontent)