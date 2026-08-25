# Print Spooler / Job Scheduler

## Overview

In this Problem Statement, I was supposed to design a mini Print Spooler / Job Scheduler system to demonstrate how different data structures can be used together to manage print jobs.

The system manages multiple printers and print jobs. Jobs can be submitted, dispatched to printers using Round Robin scheduling, cancelled, reprioritized and completed. Completed jobs are stored in history and can be reprinted. The system also maintains printer error logs and provides fast job lookup using a Dictionary.

To solve this Problem I:

1. Created a PrintJob class which contains the details of a print job such as:
   - JobId
   - FileName
   - Priority
   - Size
   - Timestamp

2. Created a CircularQueue class to manage printers. It stores the available printer numbers and provides the next printer in Round Robin order.

   For example, if there are 3 printers:

   `Printer1 -> Printer2 -> Printer3 -> Printer1 -> Printer2 -> ...`

   This makes sure that the jobs are distributed between printers in a cyclic order.

3. Created an ActiveJob class which manages active print jobs using a Doubly Linked List.

   Each node contains:
   - PrintJob
   - Previous node
   - Next node

   It supports:
   - Adding an active job
   - Removing/cancelling a job
   - Reprioritizing a job
   - Forward traversal
   - Backward traversal

4. Created a `JobStack` class to maintain the history of completed jobs.

   Since Stack follows LIFO (Last In First Out), the most recently completed job is available at the top of the stack.

   The Stack is used for:
   - Adding completed jobs
   - Retrieving the most recent completed job
   - Removing the top job if required

5. Created an `ErrorLog` class using a Singly Linked List to maintain printer error history.

   Whenever a printer fails, the error is added to the end of the list.

   For example:

   Printer 1: Paper Jam
   ->
   Printer 2: Out of Ink
   ->
   Printer 3: Printer Offline

6. Created a `PrintSpooler` class which acts as the main controller of the complete system.

   It integrates all the data structures used in the project:

   - Circular Queue for printers
   - Doubly Linked List for active jobs
   - Stack for completed job history
   - Singly Linked List for printer errors
   - Dictionary for job lookup
   - List for sorting and searching completed jobs

7. The `PrintSpooler` class uses a Dictionary which stores JobId associated with the corresponding PrintJob.

   This allows jobs to be retrieved quickly using their JobId.

   Example:

   `J101 -> Report.pdf`
   `J102 -> Resume.pdf`
   `J103 -> Assignment.pdf`

8. Job submission first checks whether the JobId already exists in the Dictionary.

   If the JobId already exists, the job is rejected as a duplicate.

   If it is a new job, it is:
   - Added to the Dictionary
   - Added to the Active Jobs Doubly Linked List

9. During job dispatch, the Circular Queue selects the next available printer.

   For example, with 3 printers:

   `J101 -> Printer 1`
   `J102 -> Printer 2`
   `J103 -> Printer 3`
   `J104 -> Printer 1`

10. When a job is completed, it is removed from the Active Jobs Doubly Linked List and added to both:
    - Job History Stack
    - Completed Jobs List

    The Stack is used for recent job reprint, while the List is used for sorting and searching.

11. The system also supports cancelling an active job.

    When a JobId is provided, the active jobs list is searched and the corresponding job is removed.

12. The system supports reprioritizing an active job.

    The active job is searched using its JobId and its priority is updated.

13. The system supports reprinting the most recently completed job.

    The `Peek()` operation of Stack is used so that the recent job can be retrieved without removing it from history.

14. Printer failures are stored in the Singly Linked List error log.

    For example:

    `Printer 2: Paper Jam`

15. Sorting is implemented using the `List<PrintJob>` collection.

    Completed jobs can be sorted according to priority.

    Example:

    `Priority 5 -> Priority 4 -> Priority 3 -> Priority 2`

16. Binary Search is implemented to search completed jobs after sorting them according to JobId.

    The search repeatedly divides the search range into two parts until the required JobId is found.

---

## Complete Workflow

The complete flow of the Print Spooler is:

    Submit Job
         |
    Check Duplicate JobId
         |
    Dictionary
         |
    Active Jobs Doubly Linked List
         |
    Dispatch Job
         |
         
    Circular Queue
         |
         
    Printer Selected
         |
         
    Job Completed
         |
         +------------------+
         |                  |
         v                  v
    History Stack     Completed Jobs List
         |                  |
         v                  v
    Recent Reprint     Sorting/Search
         
    Printer Failure
         |
         v
    Error Log
    (Singly Linked List)

## Data Structures Used

### 1. Circular Queue

Used for:

- Printer dispatch
- Round Robin scheduling

Operations:

- Get Printer
- Count


### 2. Doubly Linked List

Used for:

- Active jobs
- Job cancellation
- Job reprioritization
- Forward traversal
- Backward traversal

Each node contains:

Previous <- Job -> Next

### 3. Stack

Used for:

- Completed job history
- Recent job reprint

Operations:

- Push
- Peek
- Pop

---

### 4. Singly Linked List

Used for:

- Printer error history

Operations:

- Add error
- Display errors

---

### 5. Dictionary

Used for:

- JobId based job lookup
- Duplicate JobId checking

The Dictionary provides average O(1) lookup.


### 6. List

Used for:

- Storing completed jobs
- Sorting completed jobs
- Binary Search


## Edge Cases Handled

The following edge cases are handled in the project:

1. No printers available
2. Empty printer queue
3. Duplicate JobId
4. Invalid JobId
5. Cancelling a non-existing job
6. Reprioritizing a non-existing job
7. Printer failure
8. No completed jobs available for reprint
9. Empty completed jobs list

# Complexity Analysis

Dictionary-:
Add()    -> O(1) Average
Get()    -> O(1) Average
Lookup() -> O(1) Average

Doubly Linked List-:
Add()              -> O(1)
Remove()           -> O(n)
Reprioritize()     -> O(n)
Forward Traversal  -> O(n)
Backward Traversal -> O(n)

Singly Linked List-:
Add()     -> O(1)
Display() -> O(n)

Stack-:
Push() -> O(1)
Pop()  -> O(1)
Peek() -> O(1)

Circular Queue-:
GetPrinter() -> O(1)

Sorting-:
Sort() -> O(N log N)

Binary Search-:
Time  -> O(log N)
Space -> O(1)