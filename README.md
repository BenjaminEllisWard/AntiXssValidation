# AntiXssValidation
A class with methods for XSS (Cross site scripting) prevention.


#### Background
XSS is a malicious attack that involves inserting executable scripts into an HTML page's inputs. For example, writing:
'alert(Hello World)' wrapped in script tags into an input element in a page can allow a malicious user to execute code that can
present a vulnerability within an application. (I attempted to write the scipt tags into the example text above, but github
automatically sanitizes the text and prevents it from making it to the rendered page. This is likely an example of a XSS counter
measure that github has implemented. Otherwise, your browser may have displayed the javascipt alert when this page rendered in
your browser.) XSS has been included in OWASP's top 10 web app vulnerability list for a number of years.<br>
Read more at: https://www.owasp.org/index.php/Cross-site_Scripting_(XSS)
<br><br>
#### My AntiXssValidation class
<em>One method for preventing XSS attacks is strong input validation.</em><br>
AntiXssValidation.cs provides static methods will validate string inputs against common alpha/numeric/alphanumeric patterns.
Review the XML comments for each method to see how the parameters can accomodate specific patterns. These methods adhere
to the whitelisting principle of XSS prevention in that allowable characters are specified in the regular expressions.
