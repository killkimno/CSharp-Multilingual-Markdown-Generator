# CSharp-Multilingual-Markdown-Generator

🌏[한국어](README.kr.md) | [English](README.en.md)


Multilingual Markdown Generator

This project is based on ryul1206's multilingual-markdown project.

[Link : https://github.com/ryul1206/multilingual-markdown ](https://github.com/ryul1206/multilingual-markdown)

## Overview
It creates documents for each language using code keywords.

## How to Use
### File Rule
It should be {FileName}.base.md . For an example, see this documnet [example.base.md](example/example.base.md)

ex : Readme.base.md

### Generate Documnet
Use '문서 생성 / Generate' button to select a file and create it

### Select Main Language
Use '주 언어 / Main Language' radio button to set the primary language.
The language selected as the primary language is the .base. is removed and comes out

(ex :Readme.base.md -> Readme.md)


## Code Keyword
**Language Keyword**

A keyword that separates language-specific text areas.
After recognizing a language keyword, it is processed in that language until the next language keyword or common area keyword is encountered.

currently supported language list
```
<!-- [en] -->        
<!-- [kr] -->
<!-- [fr] -->
<!-- [jp] -->
```

**Common Area**

A keyword that delimits a text area common to all languages.

```
<!-- [common] -->   
```


**Igonore Area**

This area is used for comments. Text specified in this area will not be included in the file

```
<!-- [ignore] -->   
```


**Language Link**


Wherever this keyword appears, it will be replaced with the language-specific document link text. 
Automatically links to languages embedded in documents

```
<!-- [document_link] -->   
```









