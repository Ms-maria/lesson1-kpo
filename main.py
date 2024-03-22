from PyQt5 import uic
from PyQt5 import QtWidgets
from PyQt5.QtWidgets import QApplication, QMainWindow
import sys

def ap():
    app=QApplication(sys.argv)
    window=QMainWindow()
    window.setWindowTitle("TEST")
    window.setGeometry(500,700,610,337)
    window.show()
    sys.exit(app.exec_())

ap()