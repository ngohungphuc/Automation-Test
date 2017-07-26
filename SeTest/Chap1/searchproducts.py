from selenium import webdriver

# create a new Firefox session
driver = webdriver.Chrome("../chromedriver.exe")
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
