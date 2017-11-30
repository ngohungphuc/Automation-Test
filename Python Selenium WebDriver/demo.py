import time
from selenium import webdriver

chrome_driver_path = 'D:\Study\Automation-Test\chromedriver\chromedriver.exe'
driver = webdriver.Chrome(chrome_driver_path)

driver.get("http://github.com")
print(driver.title)
time.sleep(8)
driver.quit()