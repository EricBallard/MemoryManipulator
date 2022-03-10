# Used to cache NPC ids/names from website :P
# Strangely the name isn't stored in the NPC object and while there is an ingame method
# Npc.GetFullName() available in memeory - at this time I do not propperly understand how to call functions in memory and handle a return
# While I would love to take the time to do this properly - This is both my first time working with C# and RAM 
# So - I'll consider this still a success as I was able to use json in C# and also get some python practice in

# TODO: Will learn to call functions in memory within a future project


import time
import json
from selenium import webdriver

class NPC: 
	def __init__(self, id, name): 
		self.id = id 
		self.name = name
	
	def to_dict(self):
		return {"id": self.id, "name": self.name}

# Load chrome driver in headless mode
options = webdriver.ChromeOptions()
options.add_argument("headless")

driver = webdriver.Chrome(executable_path='C:/Users/Desktop/Desktop/test/chromedriver.exe', chrome_options=options)

# Load data page
driver.get('https://tshock.readme.io/docs/npc-list');

# Wait for page to load
time.sleep(1)

# Look for parent div
query = driver.find_elements_by_class_name('rdmd-table-inner')

# Extract table rows
rows = query[0].find_elements_by_xpath(".//tr")

# Create map to store table data
data = []

# Iterate all rows in table
for row in rows:
	# Get all the cells in row
	query = row.find_elements_by_xpath(".//td")

	# Validate
	if len(query) < 3:
		continue
		
	# Extract info from cells
	entityID = query[0].text
	entityName = query[2].text
	
	# Cache info in map
	data.append(NPC(entityID, entityName))
	
# Build array to dictionary
results = [NPC.to_dict(npc) for npc in data]

# Parse dictionary to json and write to disk
with open("data.json", "w") as outfile:
	json.dump(results, outfile, sort_keys = False, indent = 4, ensure_ascii = False)

# Print found results to console
results = len(rows)
print(f'Results: {results}')

# Close browser
driver.quit()