#!/usr/bin/env python3
import os
import re
import sys

def fix_unused_variables_in_file(file_path):
    """Fix unused variables in a single C# file"""
    try:
        with open(file_path, 'r', encoding='utf-8') as f:
            content = f.read()
        
        original_content = content
        
        # Find all variable declarations that match unused variable patterns
        lines = content.split('\n')
        modified_lines = []
        
        for line in lines:
            should_remove = False
            
            # Check for unused variable patterns
            var_patterns = [
                r'^\s*(int|double|bool)\s+(num\d+|flag\d*)\s*=\s*[^;]*;\s*$',
                r'^\s*int\s+(num\d+)\s*=\s*[^;]*;\s*$',
                r'^\s*double\s+(num\d+)\s*=\s*[^;]*;\s*$',
                r'^\s*bool\s+(flag\d*)\s*=\s*[^;]*;\s*$'
            ]
            
            for pattern in var_patterns:
                match = re.match(pattern, line.strip())
                if match:
                    # Extract variable name
                    var_name = None
                    if len(match.groups()) >= 2:
                        var_name = match.group(2)
                    elif len(match.groups()) >= 1:
                        var_name = match.group(1)
                    
                    if var_name and (var_name.startswith('num') or var_name.startswith('flag')):
                        # Count occurrences of this variable in the file
                        var_usage_count = len(re.findall(r'\b' + re.escape(var_name) + r'\b', content))
                        # If it's only used once (the declaration), remove it
                        if var_usage_count == 1:
                            should_remove = True
                            break
            
            if not should_remove:
                modified_lines.append(line)
        
        new_content = '\n'.join(modified_lines)
        
        if new_content != original_content:
            with open(file_path, 'w', encoding='utf-8') as f:
                f.write(new_content)
            print(f"Fixed unused variables in: {file_path}")
            return True
        
        return False
        
    except Exception as e:
        print(f"Error processing {file_path}: {e}")
        return False

def main():
    """Main function to process all C# files in the project"""
    base_path = "/Users/YuriiPidvirnyi/TEZ/unpacked/FinalProject/TEZ_Project.Common"
    
    if not os.path.exists(base_path):
        print(f"Base path does not exist: {base_path}")
        return
    
    files_processed = 0
    files_modified = 0
    
    for root, dirs, files in os.walk(base_path):
        for file in files:
            if file.endswith('.cs'):
                file_path = os.path.join(root, file)
                files_processed += 1
                
                if fix_unused_variables_in_file(file_path):
                    files_modified += 1
    
    print(f"\nProcessed {files_processed} C# files")
    print(f"Modified {files_modified} files")

if __name__ == "__main__":
    main()
