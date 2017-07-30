import os
from selenium import webdriver

# get the path of chromedriver
dir = os.path.dirname(__file__)
chrome_driver_path = dir + '\chromedriver.exe'

# create a new Firefox session
driver = webdriver.Chrome(chrome_driver_path)
driver.implicitly_wait(30)
driver.maximize_window()


# navigate to the application home page
driver.get("http://demo.magentocommerce.com/")

# get the search textbox
search_btn = driver.find_element_by_class_name("search")
search_btn.click()

# enter search keyword and submit
search_field = driver.find_element_by_id("edit-keys")
search_field.send_keys("phones")
search_resultBtn = driver.find_element_by_xpath('//*[@id="edit-basic"]/div/div/div[2]/div/button')
search_resultBtn.click()

# get all the anchor elements which have product names displayed
products = driver.find_element_by_class_name("result-title")
print(products.text)

# close the browser window
driver.quit()
