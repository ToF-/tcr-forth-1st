require ffl/tst.fs
require factorial.fs

: pass-or-die
  tst-errors @ if
    tst-errors ? ." failures" cr
    s" failed" exception throw
  then ;

t{ ." a dummy test" cr
  false ?false
}t


t{ ." factorial with loop" cr
  0 factl 1 ?s
  1 factl 1 ?s
  2 factl 2 ?s
  3 factl 6 ?s
}t

t{ ." factorial with recurse" cr
  0 factr 1 ?s
  2 factr 2 ?s
  3 factr 6 ?s
  4 factr 24 ?s
}t
pass-or-die
bye
