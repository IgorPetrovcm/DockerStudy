import urllib.request

fp = urllib.request.urlopen("http://localhost:5000/")

encodedContent = fp.read()
decodedContent = encodedContent.decode("utf-8")

print(decodedContent)

fp.close()