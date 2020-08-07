# ImageSorter

Media* sorter with a simple GUI designed to perform a single task: move media files (photos and videos) based on creation date into folders corresponding to the dates. Designed to be as easy to use as possible.

User selects the directory to sort and the target directory to move to. The program identifies what unique dates there are, creates folders in the target directory, and then moves files based on their "LastWrite" date (which I found to be a lot more foolproof than using Exif, as some files may not have Exif info, etc). 

The program has an error log function; if a certain file doesn't get moved, the exception will be written in a "log.txt" file in the folder where the program is run from. It also uses a seperate thread for all the functions so the program can be minimized while running, etc, and included popups for when it's done. 
