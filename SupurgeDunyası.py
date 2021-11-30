import random
class SupurgeDunyası():
    def __init__(self):
        self.durumlar = {'lok_A':random.choice(['Temiz','Kirli']),
                         'lok_B':random.choice(['Temiz','Kirli'])}
        self.done =  False
    def hareket_al(self,agent,hareket):
        if(hareket == "Sag"):
            agent.location = "lok_B"
            agent.performance -= -1
        elif(hareket == "Sol"):
            agent.location = "lok_A"
            agent.performance -= -1
        elif(hareket == "Cek"):
            if(self.durumlar[agent.location] == "Kirli"):
                agent.performance += 10
                self.durumlar[agent.location] == "Temiz"
        if(self.durumlar['lok_A'] == "Temiz" and self.durumlar['lok_B'] == "Temiz"):
            self.done = True
    def random_baslangıc(self):
        return random.choice(["lok_A","lok_B"])
class Agent():
    def __init__(self,location):
        self.performance = 0
        self.location = location
    def hareket_sec(self):
        return random.choice(["Sag","Sol","Cek"])

env = SupurgeDunyası()
agent = Agent(env.random_baslangıc)

while(not env.done):
    agent_hareketi = agent.hareket_sec()
    print(agent_hareketi)
    print(agent.location)
    print(env.durumlar)
    env.hareket_al(agent,agent_hareketi)
print(agent.performance)
