package com.kh.zoopiter.domain.BBSH.svc;

import com.kh.zoopiter.domain.BBSH.dao.BBSHDAO;
import com.kh.zoopiter.domain.BBSH.dao.BBSHFilter;
import com.kh.zoopiter.domain.common.file.svc.UploadFileSVC;
import com.kh.zoopiter.domain.entity.BBSH;
import com.kh.zoopiter.domain.entity.UploadFile;
import com.kh.zoopiter.web.common.AttachFileType;
import jakarta.transaction.Transactional;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class BBSHSVCImpl implements BBSHSVC {

//  @Autowired
//  private EntityManager entityManager;

  private final BBSHDAO BBSHDAO;
  private final UploadFileSVC uploadFileSVC;

  @Override
  public Long save(BBSH bbsh) {
    return BBSHDAO.save(bbsh);
  }

  @Transactional
  @Override
  public Long save(BBSH bbsh, List<UploadFile> uploadFiles) {
    Long bbshId = save(bbsh);
    if(uploadFiles.size() > 0) {
      uploadFiles.stream().forEach(file-> file.setRid(bbshId));
      uploadFileSVC.addFiles(uploadFiles);
    }
    return bbshId;
  }

  @Override
  public Optional<BBSH> findById(Long bbshId) {
    Optional<BBSH> bbsh = BBSHDAO.findById(bbshId);
    BBSHDAO.updateHit(bbshId);
    return bbsh;
  }

  @Override
  public int update(Long bbshId, BBSH bbsh) {
    return BBSHDAO.update(bbshId, bbsh);
  }

  @Override
  public int update(Long bbshId, BBSH bbsh, List<UploadFile> uploadFiles) {
    int cntOfupdate = BBSHDAO.update(bbshId, bbsh);
    if(uploadFiles.size() > 0) {
      uploadFiles.stream().forEach(file->file.setRid(bbshId));
      uploadFileSVC.addFiles(uploadFiles);
    }
    return cntOfupdate;
  }

  @Override
  public int delete(Long bbshId) {
    return BBSHDAO.delete(bbshId);
  }

  @Override
  public int delete(Long bbshId, AttachFileType attachFileType) {
    // 1) 게시글 삭제
    int cnt = BBSHDAO.delete(bbshId);

    //2) 물리파일 삭제
    List<UploadFile> uploadFiles = uploadFileSVC.findFilesByCodeWithRid(attachFileType,bbshId);
    List<String> files = uploadFiles.stream().map(file->file.getStore_filename()).collect(Collectors.toList());
    uploadFileSVC.deleteFiles(attachFileType, files);

    //3) 메타정보삭제
    uploadFileSVC.deleteFileByCodeWithRid(attachFileType,bbshId);
    return cnt;
  }

  @Override
  public List<BBSH> findAll() {
    return BBSHDAO.findAll();
  }

  @Override
  public List<BBSH> findAllPaging(int startRec, int endRec) {
    return BBSHDAO.findAllPaging(startRec, endRec);
  }

  @Override
  public List<BBSH> findAll(BBSHFilter filterCondition, int startRec, int endRec) {
    return BBSHDAO.findAll(filterCondition,startRec,endRec);
  }

  /**
   * 검색
   *
   * @param filterCondition 펫태그(강아지,고양이,소동물,기타)
   * @return
   */
  @Override
  public List<BBSH> findByPetType(BBSHFilter filterCondition) {
    return BBSHDAO.findByPetType(filterCondition);
  }

  /**
   * 필터 검색
   *
   * @param filterCondition 조회수, 최신순, 좋아요
   * @return
   */
  @Override
  public List<BBSH> findByFilter(BBSHFilter filterCondition) {
    return BBSHDAO.findByFilter(filterCondition);
  }

  @Override
  public int increaseHit(Long bbshId) { return BBSHDAO.updateHit(bbshId); }

  //전체건수
  @Override
  public int totalCount() {
    return BBSHDAO.totalCount();
  }

//  @Override
//  public int totalCount(String bcategory) {
//    return BBSHDAO.totalCount(bcategory);
//  }

  @Override
  public int totalCount(BBSHFilter filterCondition) {
    return BBSHDAO.totalCount(filterCondition);
  }
}


