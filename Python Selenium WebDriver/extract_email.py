from selenium import webdriver
import re

chrome_driver_path = 'D:\Study\Automation-Test\chromedriver\chromedriver.exe'
driver = webdriver.Chrome(chrome_driver_path)

driver.get('http://airindia.in/contact-details.htm')

doc = driver.page_source

emails = re.findall(r'[\w\.-]+@[\w\.-]+', doc)

for email in emails:
    print(email)
