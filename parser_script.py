import requests #pip install requests
import time
from bs4 import BeautifulSoup #pip install beautifulsoup4


url = "https://vuz.edunetwork.ru/54/32/v"


def ListToString(input):
    output = ""
 
    for line in input:
        output += line
 
    return output


def WebPageParser(url, x):
    try:
        output = []
        response = requests.get(url)
        print(response)

        bs = BeautifulSoup(response.text, 'lxml')

        name = bs.find('h1', attrs={"itemprop": "name"})
        output += [name.text.strip()]

        address = bs.find('p', 'myIcon leftIcon address')
        address = ListToString(address.text)
        address = address.replace("\xa0", " ")
        address = address.replace("\n", "")
        address = address.replace("\t", "")
        output += [address.strip()]

        website = bs.find('p', 'myIcon leftIcon site')
        output += [website.text.strip()]

        email = bs.find('p', 'myIcon leftIcon email')
        output += [email.text.strip()]

        phone = bs.find('p', 'myIcon leftIcon phone')
        if phone is None:
            phone = bs.find('div', 'col s12 m4 l3 myIcon leftIcon phone')
        phone = ListToString(phone.text)
        phone = phone.replace("\xa0", " ")
        phone = phone.replace("\n", "")
        phone = phone.replace("\t", "")
        output += [phone.strip()]
    except:
        return ''
    else:
        return ';'.join(output)
    


output_text = []
number = 440
rest_time = 10
pause_time = 5
number_of_groups = 5
group_size = 5

for group in range(1, number_of_groups + 1):
    print("Parsing group #" + str(group) + ".\n{")
    for x in range(group_size):
        number += 1
        new_url = url + str(number)
        output_text += [WebPageParser(new_url, x)]
        if (x == group_size):
            break
        time.sleep(pause_time)
    print("{\nGroup #" + str(group) + " complete.\nAwaiting " + str(rest_time) + " seconds.")
    if (x == number_of_groups):
        break
    time.sleep(rest_time)

with open(r'./List.txt', 'w') as List:
    List.write('\n'.join(output_text))