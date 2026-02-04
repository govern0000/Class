# Status

System Execute Status to Operating System if non zero is Programming Error.

If the status is 1, it is Programming Error.

If the status is 1 and the fault is Null Trigg Error, it is Programming Error.

If the status is non zero and the fault is System Programming Null Trigg Error, it is Programming Error.

If Programming Error Occur, The Execute Non Write Console Out and Err To Storage.

For Long Running Application Development, Logger is suitable to be used to write status to storage while is executing.