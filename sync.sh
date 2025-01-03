# This  script uses git to sync changes between a local and remote GitHub repository on branch 'main'.
# It assumes that the remote repository is already set up and that the local repository is already cloned.

# Steps: pull changes from remote repository, stage all changes, commit changes with message 'Updated', push changes to remote repository on branch 'main'.

# Pull changes from remote repository

git pull origin main

# Stage all changes

git add .

# Commit changes with message 'Updated'

git commit -m "Updated"

# Push changes to remote repository on branch 'main'

git push origin main
