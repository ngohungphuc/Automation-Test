import time
from selenium import webdriver
from selenium.webdriver.common.keys import Keys

browser = webdriver.Chrome('D:\Study\Automation-Test\chromedriver\chromedriver.exe')
browser.get('http://google.com')

search = browser.find_element_by_id('lst-ib')
search.send_keys('Python 3')
search.send_keys(Keys.RETURN)
time.sleep(6)
search.clear()
time.sleep(2)
browser.close()