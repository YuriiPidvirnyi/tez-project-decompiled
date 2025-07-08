#!/usr/bin/env python3
import os
import re

# Specific files and line numbers from the warnings
fixes_to_apply = [
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontPrystinnyyTyp31.cs", 5306, "num53"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontPrystinnyyTyp3.cs", 58, "num9"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/TsyklonTSN15.cs", 1053, "num"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontPrystinnyyTyp2.cs", 238, "num16"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontPrystinnyyTyp2.cs", 239, "num17"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontPrystinnyyTyp2.cs", 241, "num19"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/VidvidVRVP.cs", 21, "num2"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/VidvidVRVP.cs", 22, "num3"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/VidvidVRVP.cs", 24, "num5"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/VidvidVRVP.cs", 25, "num6"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/TsyklonTS.cs", 998, "num"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/VidvidVRNP.cs", 21, "num2"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/VidvidVRNP.cs", 22, "num3"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/VidvidVRNP.cs", 24, "num5"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/VidvidVRNP.cs", 25, "num6"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp1.cs", 54, "num7"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp3.cs", 58, "num9"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 57, "num10"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 184, "num13"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 185, "num14"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 186, "num15"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 191, "num20"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 192, "num21"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 193, "num22"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 194, "num23"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 197, "num26"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp2.cs", 203, "num32"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp31.cs", 57, "num8"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 57, "num10"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 180, "num12"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 181, "num13"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 182, "num14"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 187, "num19"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 188, "num20"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 189, "num21"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 190, "num22"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 193, "num25"),
    ("TEZ_Project.Common/TEZ_Project/Common/Products/ZontVytyazhnyy/ZontOstrivnyyTyp4.cs", 199, "num31"),
]

def fix_specific_file(file_path, line_number, var_name):
    """Remove a specific unused variable from a file"""
    try:
        with open(file_path, 'r', encoding='utf-8') as f:
            lines = f.readlines()
        
        if line_number <= len(lines):
            line = lines[line_number - 1]  # Convert to 0-based index
            
            # Check if this line contains the variable declaration
            if var_name in line and ('int ' in line or 'double ' in line or 'bool ' in line):
                # Remove the line
                lines.pop(line_number - 1)
                
                with open(file_path, 'w', encoding='utf-8') as f:
                    f.writelines(lines)
                
                print(f"Removed unused variable '{var_name}' from {file_path}:{line_number}")
                return True
        
        return False
        
    except Exception as e:
        print(f"Error processing {file_path}: {e}")
        return False

def main():
    """Apply all specific fixes"""
    base_path = "/Users/YuriiPidvirnyi/TEZ/unpacked/FinalProject"
    
    fixes_applied = 0
    
    for file_path, line_number, var_name in fixes_to_apply:
        full_path = os.path.join(base_path, file_path)
        
        if os.path.exists(full_path):
            if fix_specific_file(full_path, line_number, var_name):
                fixes_applied += 1
        else:
            print(f"File not found: {full_path}")
    
    print(f"\nApplied {fixes_applied} fixes out of {len(fixes_to_apply)} total")

if __name__ == "__main__":
    main()
