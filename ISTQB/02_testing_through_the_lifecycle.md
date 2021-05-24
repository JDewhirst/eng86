# The Test Process

![](.\images\the_test_process.png)



## Test Planning

Define the objectives of testing and the approach that will be taken

* Specifying suitable test techniques and tasks
* Who does what, who makes the progress report, who executes what tests
* Creating test schedule for meeting a deadline
* Define Exit Criteria (test completion criteria)

**Work products**

* Test plans
* Test schedule

Example exit criteria, 80% of low-medium severity faults fixes, all unit tests pass.

## Test Monitoring & Control

### Monitoring

Involves the on-going comparison of actual progress against the test plan using any test monitoring metric defined in the test plan.

### Control

Any necessary action is taken if there are any deviations (e.g. more tests may be needed).

Supported by the evaluation of **exit criteria** (definition of done).

Looking at exit criteria for test execution for a stage of testing may include.

* Check test results to see if the required test coverage has been achieved
* Determining the component or system quality by looking at both test results test logs
* Seeing if more tests are required (for example, if there are not enough tests to reach the level of risk coverage that is required.)

#### Work Products

* Test Progress Reports
* Test Summary Reports

## Test Analysis

"What is going to be tested ?" Analyse test basis to identify testable features and define associated test conditions (i.e. what are we going to test in terms of measurable coverage criteria).

Sometimes, test conditions produced as part of test analysis are used as test objectives in test charters

### Work Products

* Test Conditions (prioritised)
* Test Charters ??? (something to do with exploratory testing)

## Test Design

"How to test ?" 

* Design and prioritise test cases
* Identify test data to support test cases (derived from test conditions)
* Identify test data to be used with test cases
* Design test environment
* Capture bi-directional traceability between test basis, test conditions, test cases and test procedures.
* Test conditions are further refined

### Work Products

* Test cases and sets of test cases to exercise the test conditions defined in test analysis.
* Test data design/identification.
* Test environment design.

## Test Implementation

Often combined with test design.

"Is everything in places so that we are able to test ?"

* Creating and prioritising test procedures
* Creating test suites from test procedures
* Arranging the test suites within a test execution schedule
* Building the test environment
* Preparing test data

## Executing tests

* Execute tests and log results
* Record id of what is being tested
* Comparing actual with expected results
* Log and report defects
* Analyse anomalies to establish likely causes
* Retest and/or regression test when a defect has been corrected
* Repeated test activities as result of action taken for an anomaly or part of the planned testing

## Test Completion

* Collect data from completed test activities
* Finalising and archiving the test environment, the test data, the test infrastructure, and other testware for later reuse.
* Ensure defect reports are closed as necessary
* Analyse discrepancies to determine their cause
* Handing over the testware to the maintenance teams
* Lessons learned (improve future tests)

### Work Products

* Test summary reports
* Actionable items for improvement in subsequent projects (lessons learnt)
* Finalised testware.

# Traceability between Test basis and Test Work Products

The test basis is the 'body of knowledge' from which test cases are derived. This can include requirements, the code, business processes, user manuals, etc.

For effective Test Monitoring and Control, it is imperative to establish and maintain traceability throughout the test process between each element of the test basis and the various test work products associated with that element.