import random

sayı = random.randit(1,10)
count = 0
kullanıcı_verisi = 0


while(True):
    kullanıcı_verisi = input("Tahmini gir :")

    count +=1

    if(kullanıcı_verisi == "Çık"):
        print("Oyundan Çıktınız!")
        break

    kullanıcı_verisi = int(kullanıcı_verisi)

    if(kullanıcı_verisi > sayı):
        print("Daha küçük sayı tahmin et")

    elif(kullanıcı_verisi < sayı):
        print("Daha büyük sayı tahmin et")
        
    else:
        print("Kazandın!")
        print("Tur Sayın   : ",str(count))
        break
