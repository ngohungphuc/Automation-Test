from selenium import webdriver
import re

chrome_driver_path = 'D:\Study\Automation-Test\chromedriver\chromedriver.exe'
driver = webdriver.Chrome(chrome_driver_path)

driver.get('')

doc = driver.page_source

phones = re.findall(r'[(][\d]{3}[)][]?[\d]{3}-[\d]{4}', doc)

for phone in phones:
    print(phone)
