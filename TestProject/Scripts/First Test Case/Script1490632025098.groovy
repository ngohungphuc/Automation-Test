import static com.kms.katalon.core.checkpoint.CheckpointFactory.findCheckpoint
import static com.kms.katalon.core.testcase.TestCaseFactory.findTestCase
import static com.kms.katalon.core.testdata.TestDataFactory.findTestData
import static com.kms.katalon.core.testobject.ObjectRepository.findTestObject
import com.kms.katalon.core.checkpoint.Checkpoint as Checkpoint
import com.kms.katalon.core.checkpoint.CheckpointFactory as CheckpointFactory
import com.kms.katalon.core.mobile.keyword.MobileBuiltInKeywords as MobileBuiltInKeywords
import com.kms.katalon.core.mobile.keyword.MobileBuiltInKeywords as Mobile
import com.kms.katalon.core.model.FailureHandling as FailureHandling
import com.kms.katalon.core.testcase.TestCase as TestCase
import com.kms.katalon.core.testcase.TestCaseFactory as TestCaseFactory
import com.kms.katalon.core.testdata.TestData as TestData
import com.kms.katalon.core.testdata.TestDataFactory as TestDataFactory
import com.kms.katalon.core.testobject.ObjectRepository as ObjectRepository
import com.kms.katalon.core.testobject.TestObject as TestObject
import com.kms.katalon.core.webservice.keyword.WSBuiltInKeywords as WSBuiltInKeywords
import com.kms.katalon.core.webservice.keyword.WSBuiltInKeywords as WS
import com.kms.katalon.core.webui.keyword.WebUiBuiltInKeywords as WebUiBuiltInKeywords
import com.kms.katalon.core.webui.keyword.WebUiBuiltInKeywords as WebUI
import internal.GlobalVariable as GlobalVariable

WebUI.openBrowser('')

WebUI.navigateToUrl('https://www.google.com.vn/?gfe_rd=cr&ei=T0TZWI3SBOnc8gfk8JfYDA&gws_rd=ssl')

WebUI.setText(findTestObject('Page_github - Tm vi Google (2)/input_q'), 'github ngohungphuc')

WebUI.click(findTestObject('Page_github - Tm vi Google (2)/svg'))

WebUI.click(findTestObject('Page_github ngohungphuc - Tm vi Goo (2)/a_ngohungphuc (Tony Hudson)  G'))

WebUI.click(findTestObject('Page_ngohungphuc (Tony Hudson)  Git (2)/a_Repositories'))

WebUI.click(findTestObject('Page_ngohungphuc (Tony Hudson)  Rep (2)/a_Automation-Test'))

WebUI.closeBrowser()

