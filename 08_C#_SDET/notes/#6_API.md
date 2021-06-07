# API

Application Program Interface

Intermediary between two applications  which allows them to speak to each other in a standardised way. Enables access to a service outside of an applications code and extends the functionality of the application.

## Web API

* Defined interface available over web
* Request-response message system
* Most commonly a HTTP-based server

Often provided by a third party, may be public, may require a key.

### HTTP

Request-response system.

Used by web pages, the request is made to a web server, the response is in html to be rendered by the browser. 

The client and the server don't  know anything about each other. Each request/response pair is completely independent, the client and server do not know about each other's state. Session state is stored on the client. There is not a permanent client-server connection

![image-20210607095357690](images\http_methods.png)

#### HTTP Status Codes

[Here](https://en.wikipedia.org/wiki/Hyper_Text_Coffee_Pot_Control_Protocol)

## RESTful Services

Representation State Transfer

Used to build lightweight, maintainable and scalable web services

RESTful services should support

* Client-Server
* Stateless
* Uniform interface - HTTP method + resource URI
* Cacheable
* Layered System
* Code on demand (optional)

[RESTful architectural constraints](https://restfulapi.net/rest-architectural-constraints/)

### Uniform Interface

Guiding principles, ensures common language between servers and clients, such that we can swap any part out without breaking anything

* Identification of resources - URI
* Manipulation of resources through representations
* Self-descriptive messages 
  * Each method must contain the information needed to process it (i.e.. content-type)
* Hypermedia as the Engine of Application State (HATEOAS)
  * Use links to drive changes in application state
  * A response can contain links to the next available operation

##### URIs and Naming Resources

![image-20210607100609594](images\uri_naming.png)

![image-20210607100833781](images\resource_uri.png)

![image-20210607100924687](images\api_conventions.png)

### Representation and Data Flow

The server holds data that the client wants to retrieve or interact with, this is the resource. A representation of the resource can be passed from client to server (or vice-versa) in a form understood to both - data flow. The representation can be in a variety of formats, independent of how it is actually held on the server. Both the client and the server need to be able to read the format. The resource contract (API) should be documented: What information is available ? What format will it be in ? What parameters are there ?

![image-20210607101210658](images\http_response_request.png)

![image-20210607101341905](images\http_request)

![http response](images\http_response.png)

### Statelessness

The web service does not hold the result of the previous request, every call is new and treated the same.

![image-20210607101723103](images\stateful_stateless.png)

### Caching

Is what is seems like. Sorting generated results anywhere from the server to client side. If not managed properly can result in having the client served stale results, but otherwise can speed things up a lot.

Proxy service, another computer between the server and the client.

![image-20210607102121199](images\caching.png)

## API Testing 

Normally testing frameworks for an APIs a company is developing/has developed. May be; used in your other products, for public use - other devs will incorporate it into their products, public

The API code should be covered by unit tests. We're concerned with end-to-end performance; given a request, what is the response. Need to test does the API request/response structure fulfil the requirements/documentation

![image-20210607102517493](images\api_what_to_test.png)

### API Test Scenarios

Happy path; valid input, correct output

Unhappy; valid input

Unhappy; invalid input

**a third thing**

